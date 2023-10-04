var pilots = [
    {
      id: 2,
      name: "Wedge Antilles",
      faction: "Rebels",
      years: 10
    },
    {
      id: 8,
      name: "Ciena Ree",
      faction: "Empire",
      years: 20
    },
    {
      id: 40,
      name: "Iden Versio",
      faction: "Empire",
      years: 30
    },
    {
      id: 66,
      name: "Thane Kyrell",
      faction: "Rebels",
      years: 35
    }
  ];
  

function totalFaction() {
    let factionsCount = [];
    for (let i = 0; i < pilots.length; i++) {
        
    }
}


function totalFaction() {
    var factionsCount = {};
    for (var i = 0; i < pilots.length; i++) {
      var faction = pilots[i].faction;
      if (factionsCount[faction]) {
        factionsCount[faction]++;
      } else {
        factionsCount[faction] = 1;
      }
    }
    return factionsCount;
  }
  
  var factionCounts = totalFaction();
  
  for (var faction in factionCounts) {
    console.log(`Número de pilotos de la facción ${faction}: ${factionCounts[faction]}`);
  }