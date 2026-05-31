using Microsoft.AspNetCore.Mvc;
using Nethereum.Web3;
using RiskManagementSomnia.Controllers.CustomModel;
using RiskManagementSomnia.Controllers.Input;

namespace RiskManagementSomnia.Controllers;

[ApiController]
[Route("[controller]")]
public class RiskManagementController : ControllerBase
{
    //[HttpGet]
    //public async Task<IActionResult> Analyze(string notes)
    //{
    //    var rpcUrl = "https://dream-rpc.somnia.network";

    //    var contractAddress = "0xe01C13f6870bDB91c690a14d09Dbd7E8Be47a1B3";

    //    var abi = @"[
	   //     {
		  //      ""inputs"": [
			 //       {
				//        ""internalType"": ""string"",
				//        ""name"": ""deploymentNotes"",
				//        ""type"": ""string""
			 //       }
		  //      ],
		  //      ""name"": ""analyzeRisk"",
		  //      ""outputs"": [
			 //       {
				//        ""internalType"": ""uint256"",
				//        ""name"": """",
				//        ""type"": ""uint256""
			 //       }
		  //      ],
		  //      ""stateMutability"": ""pure"",
		  //      ""type"": ""function""
	   //     }
    //    ]";

    //    var web3 = new Web3(rpcUrl);

    //    var contract = web3.Eth.GetContract(
    //        abi,
    //        contractAddress);

    //    var function =
    //        contract.GetFunction("analyzeRisk");

    //    var result =
    //        await function.CallAsync<uint>(notes);

    //    return Ok(new
    //    {
    //        notes,
    //        riskScore = result
    //    });
    //}

    [HttpPost("analyze")]
    public async Task<IActionResult> Analyze([FromBody] RiskAnalysisUserInput input)
    {
        var result = new RiskAnalysisCustomModel
        {
            OverallRiskScore = 82,
            RiskLevel = "High",
            Summary = "The user has elevated health risks primarily due to smoking, occupational exposure, poor air quality, and insufficient sleep.",

            RiskFactors =
            [
                new RiskFactorCustomModel
                {
                    Name = "Lung Disease",
                    RiskScore = 91
                },
                new RiskFactorCustomModel
                {
                    Name = "Cardiovascular Disease",
                    RiskScore = 76
                },
                new RiskFactorCustomModel
                {
                    Name = "Sleep Disorder",
                    RiskScore = 72
                }
            ],

                    TopContributors =
            [
                new RiskContributorCustomModel
                {
                    Factor = "Smoking Habit",
                    Impact = 95
                },
                new RiskContributorCustomModel
                {
                    Factor = "Coal Mining Occupation",
                    Impact = 87
                },
                new RiskContributorCustomModel
                {
                    Factor = "Poor Air Quality",
                    Impact = 75
                }
            ],

                    Recommendations =
            [
                new RecommendationCustomModel
                {
                    Action = "Stop smoking",
                    EstimatedRiskReduction = 45
                },
                new RecommendationCustomModel
                {
                    Action = "Increase sleep duration to at least 7 hours",
                    EstimatedRiskReduction = 12
                }
            ]
                };

        return Ok(result);
    }
}
