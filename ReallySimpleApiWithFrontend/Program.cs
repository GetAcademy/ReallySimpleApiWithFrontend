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
    Console.WriteLine(DateTime.Now + " - Leste alle kontaktene");
    return contacts;
});
app.MapPost("/api/contact", (Contact contact) =>
{
    Console.WriteLine(DateTime.Now + $" - La til kontakten {contact.Name}");
    contacts.Add(contact);
});
app.UseStaticFiles();
app.Run();
