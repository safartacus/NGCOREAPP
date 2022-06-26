using NGCOREAPP.Tools;

namespace NGCOREAPP.Operation
{
    public class GenerateLink
    {
        public string Generate()
        {
            string url = "";

            Random random = new Random();

            url += random.LowerCase()+ random.UpperCase() + random.Next(999)+ random.Next(999) + random.LowerCase() + random.UpperCase();

            return url;
        }
    }
}
