using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
<<<<<<< HEAD
        public RaterFactory()
        {
        }

        public Rater Create(Policy policy, RatingEngine engine)
=======
        public Rater Create(Policy policy, IRatingContext context)
>>>>>>> origin/ISP
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
<<<<<<< HEAD
                    new object[] { engine, engine.Logger }
                    );
            } catch
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }
        }
    }
}
=======
                        new object[] { new RatingUpdater(context.Engine) });
            }
            catch
            {
                return new UnknownPolicyRater(new RatingUpdater(context.Engine));
            }
        }
    }
}
>>>>>>> origin/ISP
