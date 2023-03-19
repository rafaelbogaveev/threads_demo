onmessage = function(message) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open( "GET", "http://localhost:8000", false );
    xmlHttp.send( null );    
    console.log(xmlHttp.responseText);
}