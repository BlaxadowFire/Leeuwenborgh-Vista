use [Pirates of the eggs]

select Gerechten.GerechtNaam, Gerechten.GerechtPrijs from Gerechten,GerechtSoort where Gerechten.GerechtSoort=1 and GerechtSoort.SoortNaam='' order by Gerechten.GerechtID;