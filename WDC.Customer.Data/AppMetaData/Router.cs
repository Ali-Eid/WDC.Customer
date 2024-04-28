using System;
namespace WDC.Customers.Data.AppMetaData
{
    public static class Router
    {
        public const string root = "api";
        public const string version = "v1";
        public const string byId = "/{Id}";

        public const string rule = root + "/" + version + "/";

        public static class CustomerRouting
        {
            public const string prefix = rule + "customer";
            public const string list = prefix + "/list";
            public const string customerById = prefix + byId;
            public const string create = prefix + "/create";
            public const string update = prefix + "/update";
            public const string delete = prefix + "/delete" + byId;
        }
    }
}

