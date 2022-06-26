namespace NGCOREAPP.Models
{
    public class Link
    {
        private string _longurl="";
        public string LongUrl
        {
            get
            {
                return "http://"+_longurl;
            }
            set
            {
                _longurl = value;
            }
        }
        public string ShortUrl { get; set; } = "";
        public int ClickCount { get; set; } = 0;
        
    }
}
