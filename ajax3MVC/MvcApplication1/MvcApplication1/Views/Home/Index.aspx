<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="http://code.jquery.com/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $.get("home/CargarMarcas", function (data) {
                $.each(data, function () {
                    $("#marca").append("<option value='" + this.Id + "'>" + this.nombre + "</option>");
                });
            });

            $("#marca").change(function () {
                $("#modelos").empty();
                $.get("home/cargarmodelos", { marca: this.value }, function (modelos) {
                    $.each(modelos, function (index, item) {
                        $("#modelos").append("<option value='" + this.nombre + "'>" + this.nombre + "</option>");
                    });
                });
            });
        });


    </script>
</head>
<body>
    <select id="marca">

    </select>

    <select id="modelos"></select>

</body>
</html>
