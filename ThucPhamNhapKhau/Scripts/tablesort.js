$(function () {
    $("#table").tablesorter({
        theme: 'blue',
        widthFixed: true,
        widgets: ["zebra", "filter"],
        ignoreCase: false,
        widgetOptions: {
            filter_childRows: false,
            filter_childByColumn: false,
            filter_childWithSibs: true,
            filter_columnFilters: true,
            filter_columnAnyMatch: true,
            filter_cellFilter: '',
            filter_cssFilter: '',
            filter_defaultFilter: {},
            filter_excludeFilter: {},
            filter_external: '',
            filter_filteredRow: 'filtered',
            filter_formatter: null,
            filter_functions: null,
            filter_hideEmpty: true,
            filter_hideFilters: true,
            filter_ignoreCase: true,
            filter_liveSearch: true,
            filter_matchType: { 'input': 'exact', 'select': 'exact' },
            filter_onlyAvail: 'filter-onlyAvail',
            filter_placeholder: { search: '', select: '' },
            filter_reset: 'button.reset',
            filter_resetOnEsc: true,
            filter_saveFilters: true,
            filter_searchDelay: 300,
            filter_searchFiltered: true,
            filter_selectSource: null,
            filter_serversideFiltering: false,
            filter_startsWith: false,
            filter_useParsedData: false,
            filter_defaultAttrib: 'data-value',
            filter_selectSourceSeparator: '|'

        }

    });

    $('button[data-filter-column]').click(function () {
        var filters = [],
          $t = $(this),
          col = $t.data('filter-column'),
          txt = $t.data('filter-text') || $t.text();
        filters[col] = txt;
        $.tablesorter.setFilters($('#table'), filters, true);
        return false;
    });

});
