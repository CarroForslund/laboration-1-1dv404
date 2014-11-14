"use strict";

window.onload = function(){
	
	var convertString = function(number){
		
		if (!isNaN(number)){
			var count0 = 0;
			var countEven = 0;
			var count = 0;
			
			for (var i = 0; i < number.length; i+=1){
				
				if (parseInt(number[i]) % 2 === 0){
					if (parseInt(number[i]) === 0){
						count0 += 1;
					}
					else if (parseInt(number[i]) !== 0){
						countEven += 1;
					}
				}
				else if (parseInt(number[i]) % 2 !== 0){
					count += 1;
				}
				
			}
			return "Antal nollor: " +count0+ "<br />Antal jämna siffror: " +countEven+ "<br />Antal udda siffor: " +count;
		}
		else {
			throw new Error ("Du måste skriva in ett heltal.");
		}
	};
	// ------------------------------------------------------------------------------


	// Kod för att hantera utskrift och inmatning. Denna ska du inte behöva förändra
	var p = document.querySelector("#value"); // Referens till DOM-noden med id="#value"
	var input = document.querySelector("#string");
	var submit = document.querySelector("#send");

	// Vi kopplar en eventhanterare till formulärets skickaknapp som kör en anonym funktion.
	submit.addEventListener("click", function(e){
		e.preventDefault(); // Hindra formuläret från att skickas till servern. Vi hanterar allt på klienten.

		p.classList.remove( "error");

		try {
			var answer = convertString(input.value) // Läser in texten från textrutan och skickar till funktionen "convertString"
			p.innerHTML = answer;		// Skriver ut texten från arrayen som skapats i funktionen.	
		} catch (error){
			p.classList.add( "error"); // Växla CSS-klass, IE10+
			p.innerHTML = error.message;
		}
	
	});



};