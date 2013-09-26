(function ($) {
    
    var data = ["aaaa", "aaaaa", "abbbb", "aabb", "abc", "abcc"];
    $.fn.autocomplete = function (options) {
        var that = this;
        var $el = $(this);
        var container = $("<div></div>").insertAfter(this);

        $el.keyup(function (event) {
            if (event.keyCode === 40) {
                if (container.find("div.selected").length == 0) {
                    container.find("div:first").addClass("selected");
                } else {
                    container.find("div.selected").removeClass("selected").next().addClass("selected");
                }
                return false;
            };

            var texto = $el.val();

            $.get("data.aspx", { query: texto }, function (data) {
                crearLista(data);
            });
        });

        function crearLista(match) {
            container.empty();
            $.each(match, function(index, item){
                var item = "<div>" + item + "</div>";
                container.append(item);
            });
        };
        
    };
    
}(jQuery));