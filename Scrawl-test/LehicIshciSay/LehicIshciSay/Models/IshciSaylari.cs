namespace LehicIshciSay.Models
{
    public class IshciSaylari:DbContext
    {
        public int id { get; set; }
        public int kisisay { get; set; }    
        public int qadinsay { get; set; }
        public int servis { get; set; }
        public int kisimaas = 16,67;
        public int qadinmaas = 15;
        public DateTime gun { get; set; }
        public bool odenib { get; set; }
    }
}
