use [Pirates of the eggs]

select Gerechten.GerechtNaam, Gerechten.GerechtPrijs from Gerechten,GerechtCategorie where Gerechten.GerechtSoort=1 and GerechtCategorie.SoortNaam='' order by Gerechten.GerechtID;