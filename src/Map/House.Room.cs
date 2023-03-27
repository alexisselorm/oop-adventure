namespace OOPAdventure;

    public partial class House
    {
        private int CalculateRoomIndex(int c, int r){
            return Math.Clamp(c,-1,Width) + Math.Clamp(r,-1,Height) * Width;
        }

        public void CreateRooms(int width,int height){
            Width = Math.Clamp(width,2,10);
            Height = Math.Clamp(height,2,10);

            var total = Width * Height;

            Rooms = new Room[total];

            for (int i = 0; i < total; i++)
            {
                var tmpRoom = new Room();

                var c = i % Width; //Column
                var r = i / Width; // Row

                tmpRoom.Name = String.Format(Text.Language.DefaultName,i,c,r);
            }
        }
    }