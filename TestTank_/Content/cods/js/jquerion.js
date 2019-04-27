var Ion = {
	
	init : function(){

		$(document).ready(function() {
			
			console.log ("RUNION"); 
			
			setTimeout(function(){
			    $("#idtankCapacityMax").prop("readonly", true);
			    $("#idtankCapacityMin").prop("readonly", true);
			    $("#idliquidCapacityMax").prop("readonly", true);
			    $("#idliquidCapacityMin").prop("readonly", true);

				//$("#liquid").animate({
				//	"height": "80%"
				//}, 500);
				
			}, 1000);
			
		});

	},
		cambiarLiquido(nuevo){
		$("#liquid").animate({
			"height": nuevo
		}, 500);
}



};
		


Ion.init();











