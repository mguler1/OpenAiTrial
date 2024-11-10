using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;


var openAIService = new OpenAIService(new OpenAiOptions()
{
    ApiKey = "API KEY"
});


Console.WriteLine("Prompt Giriniz");
var  usersPrompt=Console.ReadLine();

var completionResult = await openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
{
    Messages = new List<ChatMessage>
    {
        ChatMessage.FromUser(usersPrompt)
    },
    Model = Models.Gpt_3_5_Turbo,
    MaxTokens = 1000,//optional
});
if (completionResult.Successful)
{
    Console.WriteLine(completionResult.Choices.First().Message.Content);
}
Console.ReadLine();