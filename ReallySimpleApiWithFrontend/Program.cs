using ReallySimpleApiWithFrontend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

var contacts = new List<Contact>
{
    new Contact("Per", "per@mail.com"),
    new Contact("Pål", "paa@gmail.com"),
    new Contact("Espen", "espen@online.no"),
};

app.MapGet("/api/contact", () =>
{
    return contacts;
});
app.UseStaticFiles();
app.Run();
