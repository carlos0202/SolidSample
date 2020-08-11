namespace ArdalisRating
{
    public class LandPolicyRater : Rater
    {
<<<<<<< HEAD

        public LandPolicyRater(RatingEngine engine, ConsoleLogger logger)
            : base(engine, logger)
=======
        public LandPolicyRater(IRatingUpdater ratingUpdater)
            :base(ratingUpdater)
>>>>>>> origin/ISP
        {
        }

        public override void Rate(Policy policy)
        {
<<<<<<< HEAD
            _logger.Log("Rating LAND policy...");
            _logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                _logger.Log("Land policy must specify Bond Amount and Valuation.");
=======
            Logger.Log("Rating LAND policy...");
            Logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Logger.Log("Land policy must specify Bond Amount and Valuation.");
>>>>>>> origin/ISP
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
<<<<<<< HEAD
                _logger.Log("Insufficient bond amount.");
                return;
            }
            _engine.Rating = policy.BondAmount * 0.05m;
        }
    }
}
=======
                Logger.Log("Insufficient bond amount.");
                return;
            }
            _ratingUpdater.UpdateRating(policy.BondAmount * 0.05m);
        }
    }
}
>>>>>>> origin/ISP
