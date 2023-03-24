namespace OOPAdventure;

public static class Text {
    private static Language? _language;

// Language property getter
    public static Language? Language{
        get {
            if(_language == null)
                throw new Exception("Language not set");
            return _language;
        }
    }

// Language method: Loads the language to be used. You need to pass it a whole language class 
    public static void LoadLanguage(Language language) {
        _language = language;
    }
}
