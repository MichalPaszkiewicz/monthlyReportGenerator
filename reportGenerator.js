var fs = require('fs');

String.prototype.w = function(tag, props){
	if(props == null){
		props = "";
	}
	return "\n<" + tag + " " + props + ">" + this.replace(/\n/g, "\n\t") + "</" + tag + ">";
}

var w = function(tag, props){
	if(props == null){
		props = "";
	}
	return "\n<" + tag + " " + props + ">" + "</" + tag + ">";
}

for(var i = 0; i < process.argv.length; i++){
	if(i > 1){
		console.log(process.argv[i]);
	}
}

function generateReport(graphs, master){
 
	var charts = "";
				
	for(var i = 0; i < graphs.length; i++){
		var h2String = graphs[i].name.w("h2");
		
		var chartString = w("canvas",'id="my-bar' + i + '"');
		
		var tempString = "\n";
		
		tempString += "var data" + i + " = "
		tempString += JSON.stringify(graphs[i].data);
		tempString += "\nvar options" + i + " = {};";
		tempString += "\nvar bar" + i + " = new Plot.Bar('my-bar" + i + "', data" + i + ", options" + i + ");";
		
		var fullString = chartString + tempString.w("script");
		
		charts += (h2String + fullString.w("div",'class="chart-box"')).w("div",'class="data-box"');
	}
				
	var body = charts.w("div", 'id="chart-container"');

	master = master.replace("{REPORT}", body);
	
	fs.writeFile("test.html", master, function(err) {
		if(err) {
			return console.log(err);
		}

		console.log("The file was saved!");
	}); 
}

function getMasterAndGenerateReport(graphs, styles){
	fs.readFile('master.html', function(err, data){
		if(err){ throw err; }
		console.log("Get master");
		
		var masterString = data.toString();
		
		masterString = masterString.replace("{STYLES}", styles);
		
		generateReport(graphs, masterString); 
	});
}

function getStylesAndGenerateReport(graphs){
	fs.readFile('styles.css', function(err, data){
		if(err){ throw err; }
		console.log("Get styles");
		
		getMasterAndGenerateReport(graphs, "\n" + data.toString());
	});
}
			
function getAllData(){
	fs.readFile('data.js', function(err, data){
		if(err){ throw err; }
		console.log(data);
		
		var newData = JSON.parse(data);
		
		var items = [];
		
		for(var i in newData){
			for(var j in newData[i]){
				var exists = false;		
				for(var k = 0; k < items.length; k++){
					if(items[k] == j){
						exists = true;
					}
				}		
				if(!exists){
					items.push(j);
				}
			}
		}
		
		var graphs = [];
		
		for(var i = 0; i < items.length; i++){
			var tempGraph = {};
			
			for(var j in newData){
				tempGraph[j] = newData[j][items[i]] | 0;
			}
			
			graphs.push({name: items[i], data: tempGraph});
		}
		
		getStylesAndGenerateReport(graphs);
	});
}

getAllData();

//generateReport(data);