using System;

namespace Singleton
{
    class CzechPresident
    {
        private static CzechPresident _instance;

        public static CzechPresident GetCurrentPresident()
        {
            if (_instance == null)
            {
                _instance = new CzechPresident();
                _instance.ElectionTime = DateTime.Now;
            }

            return _instance;
        }

        private DateTime ElectionTime { get; set; }

        public string IntroduceYourself() =>
$@"I am President of the Czech Republic, Milos Zelman!
I am holding office for {(DateTime.Now - ElectionTime).TotalSeconds.ToString("#.##")} seconds.";
    }
}
