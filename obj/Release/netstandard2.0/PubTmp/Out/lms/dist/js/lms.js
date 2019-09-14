//Datatables
window.dataTableCreate = (tableName) => {
    $('#MyTasksTable').DataTable({
        "order": [[0, "desc"]],
        responsive: true     
    });
    //"order": [[0, "desc"]],
    // Your function currently has to return something. For demo
    // purposes, we just return `true`.
    return true;
};

window.dataTableDestroy = (tableName) => {
    if ($('#MyTasksTable').length) {
        $('#MyTasksTable').DataTable().destroy();
    }
    return true;
};

//Datatables
window.dataTableCreate1 = (tableName) => {
    $('#MyReportsTable').DataTable({
        "order": [[0, "desc"]],
        responsive: true
    });
    //"order": [[0, "desc"]],
    // Your function currently has to return something. For demo
    // purposes, we just return `true`.
    return true;
};

window.dataTableDestroy1 = (tableName) => {
    if ($('#MyReportsTable').length) {
        $('#MyReportsTable').DataTable().destroy();
    }
    return true;
};

window.alertx = (data) => {
    console.dir(data);
    // Your function currently has to return something. For demo
    $('#exampleModalCenter').modal('show');
    // purposes, we just return `true`.
    return true;
};

window.printContent = (data) => {
    // Your function currently has to return something. For demo
    window.print();
    // purposes, we just return `true`.
    return true;
};

window.fileUpload = (data) => {
    // Your function currently has to return something. For demo
    // Upload the file.
    // You can upload files up to 2 GB with the REST API.

        // Define the folder path for this example.
        //var serverRelativeUrlToFolder = attachmentsFolder;

        // Get test values from the file input and text input page controls.
        var fileInput = jQuery('#'+data.controlId);
        var fileCount = fileInput[0].files.length;
        // Get the server URL.
        var filesUploaded = 0;
        for (var i = 0; i < fileCount; i++) {
            // Initiate method calls using jQuery promises.
            // Get the local file as an array buffer.
            var getFile = getFileBuffer(i);
            getFile.done(function (arrayBuffer, i) {

                // Add the file to the SharePoint folder.
                var addFile = addFileToFolder(arrayBuffer, i);
                addFile.done(function (file, status, xhr) {
                    filesUploaded++;
                    if (fileCount === filesUploaded) {
                        filesUploaded = 0;
                        return true;
                    }
                });
                return false;
                //addFile.fail(onError);

            });
            return false;
            //getFile.fail(onError);

        }

        // Get the local file as an array buffer.
        function getFileBuffer(i) {
            var deferred = jQuery.Deferred();
            var reader = new FileReader();
            reader.onloadend = function (e) {
                deferred.resolve(e.target.result, i);
            };
            reader.onerror = function (e) {
                deferred.reject(e.target.error);
            };
            reader.readAsArrayBuffer(fileInput[0].files[i]);
            return deferred.promise();
        }

        // Add the file to the file collection in the Shared Documents folder.
        function addFileToFolder(arrayBuffer, i) {
            var index = i;

            // Get the file name from the file input control on the page.
            var fileName = fileInput[0].files[index].name;

            // Construct the endpoint.
            var fileCollectionEndpoint = data.url + "/_api/web/lists(guid'" + data.listGuidMain + "')/items('" + data.itemId +"')/AttachmentFiles/add(FileName='"+ fileName  +"')";

            // Send the request and return the response.
            // This call returns the SharePoint file.
            return jQuery.ajax({
                url: fileCollectionEndpoint,
                type: "POST",
                data: arrayBuffer,
                processData: false,
                async: true,
                headers: {
                    "accept": "application/json;odata=verbose",
                    "X-RequestDigest": data.digest
                   
                }
            });
        }
    // purposes, we just return `true`.
    // "content-length": arrayBuffer.byteLength
    //return false;
};

// Display error messages. 
function onError(error) {
    alert(error.responseText);
}