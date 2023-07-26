function successalert() {

    swal({
        title: 'Operación completada con exito',
        text: '',
        type: 'success'
    });
}

function errorpassword() {
    swal({
        title: 'Contraseña incorrecta',
        text: 'La contraseña no coincide con la registrada',
        type: 'error'
    }
    );

}

function voidpassword() {
    swal({
        title: 'Contraseña Vacia',
        text: 'Digita la contraseña',
        type: 'error'
    });

}

function voidmail() {

    swal({
        title: 'Correo vacio',
        text: 'Digita el correo',
        type: 'error'

    });


}


function voidall() {

    swal({
        title: 'Campos Faltantes',
        text: 'Digita los campos faltantes',
        type: 'error'


    });


}

function notpassEquals() {

    swal({
        title: 'Las contraseñas no coinciden',
        text: 'Asegurate que las contraseñas coincidan',
        type: 'error'


    });


}

function AlreadyExistUser() {
    swal({
        title: 'USUARIO EXISTENTE',
        text: 'Este correo ya existe en la base de datos',
        type: 'error'
    });
}

function UserorpasswordError() {
    swal({
        title: 'USUARIO O CONTRASEÑA NO VALIDOS',
        text: 'Compruebe los valores ingresados',
        type: 'error'
    });
}

function UserNotFound() {
    swal({
        title: 'El usuario no fue encontrado',
        text: 'Lamentamos mucho las molestias, vuelva a intentarlo con otro correo',
        type: 'error'
    });
}

function MailsendNotification() {
    swal({
        title: 'Se a enviado un correo',
        text: 'Se te pedira el codigo que llego al correo que indicaste',
        type: 'success'
    });
}

function FailMailsendNotification() {
    swal({
        title: 'A ocurrido un error',
        text: 'No se pudo vincular el codigo con la base de datos o con tu correo',
        type: 'error'
    });
}

function IncorrectCode() {
    swal({
        title: 'Codigo incorrecto',
        text: 'El codigo que ingresaste es incorrecto, revisa tu correo electronico para saber codigo',
        type: 'error'
    });
}

function Errorgen() {
    swal({
        title: 'No se veia venir',
        text: 'A ocurrido un error inesperado',
        type: 'error'
    });
}

function NoImgUpload() {
    swal({
        title: 'No has cargado ninguna imagen',
        text: 'Porfavor carga una imagen para poder añadirla a tu foto de perfil',
        type: 'error'
    });
}

function cantAddUser() {
    swal({
        title: 'No se a podido agregar a este usuario',
        text: 'Es probable que este usuario ya este agregado a tu proyecto o no se encuentre disponible',
        type: 'error'
    });
}


function UpdatedAccessUser() {
    swal({
        title: 'El acceso del proyecto del usuario a sido actualizado',
        text: 'Ahora el podra ejercer el rol asignado',
        type: 'success'
    });
}

function AccessDenied() {
    swal({
        title: 'No tienes permisos para esto',
        text: 'No se pudo ejecutar la acción',
        type: 'error'
    });
}


