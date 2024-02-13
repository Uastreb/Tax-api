namespace TAX.Routes
{
    public static class TaxRoutes
    {
        public static string GetNameFromTaxByUNPRoute(string unp) => string.Format("api/grp-public/data?unp={0}&charset=UTF-8&type=json", unp);
    }
}