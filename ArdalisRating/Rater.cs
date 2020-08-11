namespace ArdalisRating
{
    public abstract class Rater
    {
<<<<<<< HEAD
        protected readonly RatingEngine _engine;
        protected readonly ConsoleLogger _logger;

        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
=======
        protected readonly IRatingUpdater _ratingUpdater;
        public ILogger Logger { get; set; } = new ConsoleLogger();

        public Rater(IRatingUpdater ratingUpdater)
        {
            _ratingUpdater = ratingUpdater;
>>>>>>> origin/ISP
        }

        public abstract void Rate(Policy policy);
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> origin/ISP
