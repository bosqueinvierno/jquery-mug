<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
    <script src="../../Scripts/jquery-1.7.1.min.js"></script>
    <script src="../../Scripts/jquery.validate.js"></script>
    <script src="http://malsup.github.io/min/jquery.form.min.js" ></script>
    <script >
        $(function () {
            $("#frm").ajaxForm().validate({
                rules: {
                    nombre: {
                        required: true,
                        maxlength: 5
                    }
                }, messages: {
                    nombre:{ 
                        required: jQuery.format("el campo {2} es requerido")
                    }
                }
            });
        });

    </script>
</head>
<body>
    <div>
        <form id="frm" action="home/new" method="post">
            <input type="text" id="nombre" name="nombre" />
            <input type="text" name="email" />
            <input type="text" name="edad" />
            <input type="submit" value="enviar" />
        </form>
    </div>
</body>
</html>
