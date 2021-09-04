const file_input = document.getElementById("file_input");
const submit_file = document.getElementById("submit_file");

submit_file.addEventListener("click", () => {

    for (let index = 0; index < file_input.files.length; index++) {
        const element = file_input.files.item(index)
        const encoded=encodeURI( file_input.files.item(index).name)
        element.arrayBuffer().then((buffer) => {
            fetch(`/api/UploadRecieve/${encoded}`, {
                method: "POST",
                body: buffer
            })
        })
    }
})