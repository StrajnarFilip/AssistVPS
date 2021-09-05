const file_input = document.getElementById("file_input");
const submit_file = document.getElementById("submit_file");
const secure_password=document.getElementById("secure_password");

submit_file.addEventListener("click", () => {
    if(secure_password.value.length != 64){
        alert("Password must be precisely 64 characters long!")
        return
    }

    document.cookie=`secure_password=${secure_password.value}`

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