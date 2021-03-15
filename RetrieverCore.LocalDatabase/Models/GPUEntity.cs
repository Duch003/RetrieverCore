namespace RetrieverCore.LocalDatabase.Models
{
    public class GPUEntity
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public double MemorySize { get; set; }
        public string Model { get; set; }
        public int ScreenHeight { get; set; }
        public int ScreenWidth { get; set; }
    }
}
