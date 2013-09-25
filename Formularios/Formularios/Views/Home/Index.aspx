<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
    <script src="../../Scripts/jquery-1.7.1.js"></script>
    <script src="../../Scripts/jquery.validate.js"></script>
    <script src="http://malsup.github.io/jquery.form.js"></script>
    <script>
        $(function () {
            var options = {
                rules: {
                    nombre: {
                        required: true,
                        maxlength: 5
                    },
                    email: {
                        email: true
                    },
                    edad:{
                        range: [18, 65]
                    }
                },
                messages: {
                    nombre: {
                        required: "el nombre tiene que estar"
                    },
                    edad: {
                        range: "el rango tiene que estar entre {0} y {1}"
                    }
                }
            };
            $("#frm").ajaxForm().validate(options);
        });

    </script>
</head>
<body>
    <div>
        <form id="frm" action="/home/alta" method="get">
            <input type="text" id="nombre" name="nombre" />
            <input type="text" id="email" name="email" />
            <input type="text" id="edad" name="edad" />
            <input type="submit" value="enviar " />
        </form>
    </div>
</body>
</html>
