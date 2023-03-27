namespace OOPAdventure;

    public sealed class Actions
    {
        private static Actions? _instance;

        public static Actions Instance { 
            get { 
                if (_instance == null)
                    _instance = new Actions();
                return _instance;
             }
        }

        private readonly Dictionary<string, Action> _registredActions = new();
        private Actions(){

        }
        
        public void Register(Action action){
            var name = action.Name.ToLower();

            if (_registredActions.ContainsKey(name))
                _registredActions[name] = action;
            else
                _registredActions.Add(name, action);
        }

        public void Execute(string[] args)
        {
            var actionName = args[0];
            if (_registredActions.ContainsKey(actionName))
                _registredActions[actionName].Execute(args);
            else
                Console.WriteLine(Text.Language.ActionError);
                
        }
        
    }