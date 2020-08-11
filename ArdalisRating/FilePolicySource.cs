<<<<<<< HEAD
﻿using System;
using System.IO;
=======
﻿using System.IO;
>>>>>>> origin/ISP

namespace ArdalisRating
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> origin/ISP
