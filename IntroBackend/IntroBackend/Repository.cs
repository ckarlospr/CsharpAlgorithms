namespace IntroBackend
{
    public class Repository
    {
        List<Brewery> brewery = new List<Brewery>()
        {
            new Brewery() { Id=1, Name = "Minerva"},
            new Brewery() { Id=2, Name = "Belching Beaver"},
            new Brewery() { Id=3, Name = "Samichlaus"}
        };
    }

    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
