namespace DesktopJournal
{
    internal class Singleton
    {
        private static Singleton _instance;
        private Form1 _form1;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance; 
            }
        }

        public Form1 Form1
        {
            get
            {
                if(_form1 == null || _form1.IsDisposed)
                    _form1 = new Form1();
                return _form1;

            }
        }
    }
}
