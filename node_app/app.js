const express=require("express")
const host = 'localhost';
const port = 8000;

const cors = require("cors");
const corsOptions = {
    origin: "http://127.0.0.1:5500",
};

const app = express()
app.use(cors(corsOptions))


app.get('/', (req, res) =>{
    setTimeout(function() {
        res.send(new Date());
      }, 3000);
});
app.listen(port);
