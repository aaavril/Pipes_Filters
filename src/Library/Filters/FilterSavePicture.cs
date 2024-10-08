namespace CompAndDel;
    public class FilterSavePicture: IFilter
    {
        private PictureProvider p = new PictureProvider();
        private string Path { get; set; }

        public FilterSavePicture(string path)
        {
            this.Path = path;
        }

        public IPicture Filter(IPicture image)
        {
           p.SavePicture(image, Path);
           return image;
        }
    }