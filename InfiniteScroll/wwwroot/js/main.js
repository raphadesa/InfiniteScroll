var pageNo = 1;
window.InfiniteScroll = {
    
    Start: function() {                
        
        var loadMore = function () {
            DotNet.invokeMethodAsync('InfiniteScroll', 'LoadMore', pageNo);
            pageNo++;
        }
        //Special thanks to : https://buzut.net/creer-un-scroll-infini-en-jquery/
        // Detect when scrolled to bottom.
        var deviceAgent = navigator.userAgent.toLowerCase();
        var agentID = deviceAgent.match(/(iphone|ipod|ipad)/);

        // on déclence une fonction lorsque l'utilisateur utilise sa molette
        $(window).scroll(function () {
            // cette condition vaut true lorsque le visiteur atteint le bas de page
            // si c'est un iDevice, l'évènement est déclenché 150px avant le bas de page
            if (($(window).scrollTop() + $(window).height()) == $(document).height()
                || agentID && ($(window).scrollTop() + $(window).height()) + 150 > $(document).height()) {
                // on effectue nos traitements
                loadMore();
            }
        });

        // Initially load some items.
        loadMore();
    }
}