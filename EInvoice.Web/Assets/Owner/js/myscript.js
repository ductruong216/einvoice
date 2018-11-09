$(document).ready(function () {
	$('.list-unstyled a').filter(function () { return this.href === location.href }).parent().addClass('active')
		.siblings().removeClass('active');
});
$(document).ready('.list-unstyled a').click(function () {
	$(this).parent().addClass('active').siblings().removeClass('active');
});