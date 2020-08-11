using System;

namespace ArdalisRating
{
<<<<<<< HEAD
    internal class LifePolicyRater : Rater
    {

        public LifePolicyRater(RatingEngine engine, ConsoleLogger logger)
            : base(engine, logger)
=======
    public class LifePolicyRater : Rater
    {
        public LifePolicyRater(IRatingUpdater ratingUpdater)
            : base(ratingUpdater)
>>>>>>> origin/ISP
        {
        }

        public override void Rate(Policy policy)
        {
<<<<<<< HEAD
            _logger.Log("Rating LIFE policy...");
            _logger.Log("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                _logger.Log("Life policy must include Date of Birth.");
=======
            Logger.Log("Rating LIFE policy...");
            Logger.Log("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Logger.Log("Life policy must include Date of Birth.");
>>>>>>> origin/ISP
                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
<<<<<<< HEAD
                _logger.Log("Centenarians are not eligible for coverage.");
=======
                Logger.Log("Centenarians are not eligible for coverage.");
>>>>>>> origin/ISP
                return;
            }
            if (policy.Amount == 0)
            {
<<<<<<< HEAD
                _logger.Log("Life policy must include an Amount.");
=======
                Logger.Log("Life policy must include an Amount.");
>>>>>>> origin/ISP
                return;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
<<<<<<< HEAD
                _engine.Rating = baseRate * 2;
                return;
            }
            _engine.Rating = baseRate;
        }
    }
}
=======
                _ratingUpdater.UpdateRating(baseRate * 2);
                return;
            }
            _ratingUpdater.UpdateRating(baseRate);
        }
    }
}
>>>>>>> origin/ISP
