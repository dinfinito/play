
$(document).ready(function(){
    $('#btnSave').on('click', function(){
        var Collection = new FormData();
        Collection.append('Firstname','Dheeraj');
        Collection.append('Document', $('#fileDocument').get(0).files[0]);
        $.ajax({
            type : 'POST',
            url: '/Play/Save',
            data : Collection, 
            processData : false,
            contentType: false,
            success: function(response){
                console.log('in success: '+response)
            },
            error: function(error){
                console.log('in error')
            }
        });
    });
});