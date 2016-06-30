window.fbAsyncInit = function () {
    FB.init({
        appId: '148907218850991',
        xfbml: true,
        version: 'v2.6'
    });
};

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

/*...........................*/
//FUNCIONES PARA ACCEDER AL API
//compartir en fb
function compartirfb() {
    FB.ui(
        {
            method: 'share',
            href: 'https://developers.facebook.com/docs/'
        },
        //respuesta
        function (response) {
            if (response && !response.error_message) alert('Posting completed.'); else alert('Error while posting.');
        }
        )
};

//logeo en fb
function loginfb() {
    FB.login(function (response) {
        if (response.status === 'connected') {
            FB.api('/me', 'GET', { fields: 'id,first_name,last_name' },
        function (response) {

            document.getElementById("FBIDRS").value = response.id;
            document.getElementById("FBnombre").value = response.first_name;
            document.getElementById("FBapellido").value = response.last_name;
            document.getElementById("FBImgRS").value = "http://graph.facebook.com/" + response.id + "/picture?type=large";
            document.getElementById("mform").submit();
        });
            console.log('Logged in.');
        }
    }, { scope: 'public_profile', scope: 'email' });
}

//logout : function(callback) {FB.logout(callback);},