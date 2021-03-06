﻿namespace AttackSurfaceAnalyzer.Objects
{
    public class WifiObject : CollectObject
    {
        public WifiObject(string SSID)
        {
            this.SSID = SSID;
        }

        public string? Authentication { get; set; }

        public string? Encryption { get; set; }

        public override string Identity
        {
            get
            {
                return SSID;
            }
        }

        public string? Password { get; set; }
        public string SSID { get; }
    }
}