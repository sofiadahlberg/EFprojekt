# Webbutveckling med .NET Projekt
Det här momentet består av två olika delar: 
- .NET web service (ef) med admingränssnitt med full crud funktionalitet som skapats med scaffolding.
Admingränssnittet skapades med inlogg och möjlighet att registrera ny användare. Sidan används
som ett admingränssnitt för personal som jobbar på den fiktiva frisörsalongen Luddeby's frisör. På
sidan finns tre olika undersidor: Bokade tider, behandlingar och tidsintervall. De tabeller som skapades var customer, treatments och timeinterval.
- Blazor WebAssembly för FrontEnd som är en publik sida för kunderna. Där kunder kan boka nya besök. 

### Installationer
För att skapa ett .NET Web Service (EF)  projekt gjordes en dotnet new mcv [namnpåprojekt] auth Individual-installation. 
- Nugetpaket: Entity.FrameworkCore.SqlServer
- Nugetpaket: VisualStudio.Web.CodeGeneration.Design

### Modell för customer
CustomerId int auto increment, Firstname string, Lastname string, PhoneNumber string, Date DateTime, TreatmentId (FK)
### Metod/ändpunkt/beskrivning
- GET/customer/ Hämtar alla kunder som har bokat tid
- GET/customer/ID/ Hämtar specifik kund kopplat till Id.
- POST/customer/Lägger till ny bokning för kund.
- PUT/customer/ID/ Ändrar information på existerande bokning med angivet ID.
- Delete/customer/ID/ Raderar kund och bokning.
### Modell för TimeInterval
- TimeIntervalId int auto increment, StartTime DateTime, EndTime DateTime, Available Bool

  ### Metod/ändpunkt/beskrivning
- GET/timeinterval/ Hämtar alla tidsintervall
- GET/timeinterval/ID/ Hämtar specifik tidsintervall kopplat till Id.
- POST/timeinterval/Lägger till ny tidsintervall.
- PUT/timeinterval/ID/ Ändrar information på existerande tidsintervall med angivet ID.
- Delete/timeinterval/ID/ Raderar tidsintervall.

### Modell för Treatment
- TreatmentId int auto increment, Duration int, Category string, TimeIntervalId (FK)

  ### Metod/ändpunkt/beskrivning
- GET/treatment/ Hämtar alla behandlingar
- GET/treatment/ID/ Hämtar specifik behandling kopplat till Id.
- POST/treatment/Lägger till ny behandling
- PUT/treatment/ID/ Ändrar information på existerande behandling med angivet ID.
- Delete/treatment/ID/ Raderar behandling
  
