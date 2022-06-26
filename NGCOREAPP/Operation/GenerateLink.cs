using NGCOREAPP.Models.List;
using NGCOREAPP.Tools;

namespace NGCOREAPP.Operation
{
    public class GenerateLink
    {
        public string Generate()
        {
            string url = "";

            Random random = new Random();
            Repeat:
            url += random.LowerCase()+ random.UpperCase() + random.Next(999) + random.LowerCase() + random.UpperCase();
            if (Links.LinkList.Any(x => x.ShortUrl == url))
            {
                goto Repeat;
            }
            return url;

        }
    }
}
