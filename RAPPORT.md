# Rapport

**Kurs:** Grundläggande OOP i C#  

**Uppgift:**  Drommatchen

**Grupp:**  Zombie

**Datum:**  19-09-2026

**GitHub:**  


---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [Namn 1] | Zip + RAPPORT.md + REFLEKTION.md |
| [Yuk Ting Ku] | REFLEKTION.md |
| [Namn 3] | REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Vi skapade två klasser: "Spelare" och "Match". 
- I "Match" skapades privata fält för "_hemmalag", "_bortalag" och "_datum" som exponeras via publika properties med "private set". 
- I "Spelare" skapades privata fält för "_namn", "_nummer", "_position" samt ett extra fält "_mål" för att lagra antalet gjorda mål. Även dessa skyddas med "private set".

### Metoderna

- **Presentera**: Skriver ut matchens hemmalag, bortalag och datum till konsolen utifrån datan i "Match".
- **AnnounceraMålskytt(Spelare spelare)**: Tar emot ett "Spelare"-objekt som parameter och skriver ut spelarens nummer, namn och position i målmeddelandet.

### Main()

- I "Program.cs" skapade vi 4 instanser av "Spelare" och en instans av "Match". Därefter anropade vi "match.Presentera()" samt "match.AnnounceraMålskytt()" för spelarna som gjorde mål. Till sist kontrollerade vi vilka som var matchhjältar genom att anropa "match.ÄrMatchhjälte()" och skriva ut resultatet.

### Git

- Vi lade till en ".gitignore"-fil för att exkludera tillfälliga filer som "bin/", "obj/" och ".vs/". Vi har gjort regelbundna commits med tydliga meddelanden under arbetets gång. Alla i gruppen har lagts till som collaborators på GitHub-repot.

### Kodkvalitet

- Vi följde C#-standard för namngivning (PascalCase för klasser/metoder/properties och camelCase med understreck för privata fält). Koden är ren och självförklarande, och vi säkerställde att varje klass har ett tydligt och avgränsat ansvarsområde.

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

- Vi lade till fältet "_mål" och propertyn "Mål" i "Spelare"-klassen samt uppdaterade dess konstruktor. I "Match"-klassen skapade vi metoden "public bool ÄrMatchhjälte(Spelare spelare)" som returnerar "true" om spelaren har gjort minst 1 mål ("spelare.Mål >= 1"), annars "false".

### Varför vi löste det såhär

- Metoden returnerar en "bool" istället för att skriva ut text direkt för att följa Single Responsibility Principle (SRP). Metodens enda uppgift är att beräkna logiken (om spelaren uppfyller kraven för att vara matchhjälte), inte att bestämma hur eller var resultatet ska visas. 

Genom att returnera ett "bool"-värde blir koden mer återanvändbar och flexibel — värdet kan i framtiden användas i "if"-satser, sparas i en databas eller visas i ett grafiskt gränssnitt (GUI) istället för att vara fastlåst till "Console.WriteLine()".


---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```
