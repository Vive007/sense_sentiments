using MyMLApp;
// Add input data
var sampleData = new SentimentModel.ModelInput()
{ 
   // Col0 = "This restaurant was bad."
};
Console.Write("pls enter how many sentiments you have :");
string scount = Console.ReadLine();
int count;
bool check=Int32 .TryParse(scount,out count);
if (check)
{
    while (count != 0)
    {
        Console.Write("pls enter your {0} sentiments here :", count);
        sampleData.Col0 = Console.ReadLine();
        // Load model and predict output of sample data
        var result = SentimentModel.Predict(sampleData);

        // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
        var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
        Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
        count = count - 1;
    }
}
else
    Console.WriteLine("There is parshing error");