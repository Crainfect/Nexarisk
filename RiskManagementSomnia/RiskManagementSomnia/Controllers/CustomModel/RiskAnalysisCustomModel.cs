namespace RiskManagementSomnia.Controllers.CustomModel
{
    public class RiskAnalysisCustomModel
    {
        public int OverallRiskScore { get; set; }

        public string RiskLevel { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;

        public List<RiskFactorCustomModel> RiskFactors { get; set; } = [];

        public List<RiskContributorCustomModel> TopContributors { get; set; } = [];

        public List<RecommendationCustomModel> Recommendations { get; set; } = [];
    }

    public class RiskFactorCustomModel
    {
        public string Name { get; set; } = string.Empty;

        public int RiskScore { get; set; }
    }

    public class RiskContributorCustomModel
    {
        public string Factor { get; set; } = string.Empty;

        public int Impact { get; set; }
    }

    public class RecommendationCustomModel
    {
        public string Action { get; set; } = string.Empty;

        public int EstimatedRiskReduction { get; set; }
    }
}
