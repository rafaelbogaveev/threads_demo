const runBtn = document.querySelector("#runBtn");
const worker = new Worker("worker.js");

runBtn.addEventListener("click", (event) => {
    worker.postMessage("request1")
    worker.postMessage("request2")
});
