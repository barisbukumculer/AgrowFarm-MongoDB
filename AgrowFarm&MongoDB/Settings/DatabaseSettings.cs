namespace AgrowFarm_MongoDB.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string AboutCollectionName { get; set; }
        public string BannerCollectionName { get; set; }
        public string OurServiceCollectionName { get; set; }
        public string StatisticCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string VideoBannerCollectionName { get; set; }
        public string WhyUsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
