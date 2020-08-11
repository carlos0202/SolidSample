namespace ArdalisRating
{
    public class FloodPolicyRater : Rater
    {
<<<<<<< HEAD

        public FloodPolicyRater(RatingEngine engine, ConsoleLogger logger)
            : base(engine, logger)
=======
        public FloodPolicyRater(IRatingUpdater ratingUpdater)
            : base(ratingUpdater)
>>>>>>> origin/ISP
        {
        }

        public override void Rate(Policy policy)
        {
<<<<<<< HEAD
            _logger.Log("Rating FLOOD policy...");
            _logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                _logger.Log("Flood policy must specify Bond Amount and Valuation.");
=======
            Logger.Log("Rating FLOOD policy...");
            Logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Logger.Log("Flood policy must specify Bond Amount and Valuation.");
>>>>>>> origin/ISP
                return;
            }
            if (policy.ElevationAboveSeaLevelFeet <= 0)
            {
<<<<<<< HEAD
                _logger.Log("Flood policy is not available for elevations at or below sea level.");
=======
                Logger.Log("Flood policy is not available for elevations at or below sea level.");
>>>>>>> origin/ISP
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
<<<<<<< HEAD
                _logger.Log("Insufficient bond amount.");
                return;
            }
            decimal multiple = 1.0m;
            if (policy.ElevationAboveSeaLevelFeet < 100)
            {
                multiple = 2.0m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 500)
            {
                multiple = 1.5m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 1000)
            {
                multiple = 1.1m;
            }
            _engine.Rating = policy.BondAmount * 0.05m * multiple;
        }
    }
}
=======
                Logger.Log("Insufficient bond amount.");
                return;
            }
            decimal multiple = 1.0m;
            if(policy.ElevationAboveSeaLevelFeet < 100)
            {
                multiple = 2.0m;
            } else if (policy.ElevationAboveSeaLevelFeet < 500)
            {
                multiple = 1.5m;
            } else if (policy.ElevationAboveSeaLevelFeet < 1000)
            {
                multiple = 1.1m;
            }
            _ratingUpdater.UpdateRating(policy.BondAmount * 0.05m * multiple);
        }
    }
}
>>>>>>> origin/ISP
