(function($){
var defaults = {text: "search..."};
	$.fn.cajita = function(options){
		var that = this;
		$.extend(defaults, options);
		this.val(defaults.text);
		
		
	};

})(jQuery);