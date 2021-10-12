using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.DE.Localizers
{
    public class TurkishGridLocalizer : GridLocalizer
    {
        public override string Language { get { return "Turkish"; } }
        public override string GetLocalizedString(GridStringId id)
        {
            string ret = "";
            switch (id)
            {
                // ... 
                case GridStringId.GridGroupPanelText: return "Filtrelemek için bir başlığı sürükleyin";
                case GridStringId.MenuColumnClearSorting: return "Sıralamayı kaldır";
                case GridStringId.MenuGroupPanelHide: return "Gruplandırmayı gizle";
                case GridStringId.MenuGroupPanelShow: return "Gruplandırmayı göster";
                case GridStringId.MenuColumnRemoveColumn: return "Sütunu kaldır";
                case GridStringId.MenuColumnFilterEditor: return "Filtre düzenle";
                case GridStringId.MenuColumnFindFilterShow: return "Arama yap";
                case GridStringId.MenuColumnAutoFilterRowShow: return "Gelişmiş Filtreleme";
                case GridStringId.MenuColumnSortAscending: return "Artan sıralama";
                case GridStringId.MenuColumnSortDescending: return "Azalan sıralama";
                case GridStringId.MenuColumnGroup: return "Grupla";
                case GridStringId.MenuColumnUnGroup: return "Grup kaldır";
                case GridStringId.MenuColumnColumnCustomization: return "Sütun özelleştirme";
                case GridStringId.MenuColumnBestFit: return "Optimum genişlik";
                case GridStringId.MenuColumnFilter: return "Filtre";
                case GridStringId.MenuColumnClearFilter: return "Filtreyi temizle";
                case GridStringId.MenuColumnBestFitAllColumns: return "Optimum genişlik (Tüm sütunlar)";
                case GridStringId.FilterBuilderApplyButton: return "Uygula";
                case GridStringId.FilterBuilderCancelButton: return "İptal";
                case GridStringId.FilterBuilderOkButton: return "Tamam";
                // ... 
                default:
                    ret = base.GetLocalizedString(id);
                    break;
            }
            return ret;
        }
    }

    public class TurkishEditorsLocalizer : Localizer
    {
        public override string Language { get { return "Turkish"; } }
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                // ...
                case StringId.NavigatorTextStringFormat: return "{0} -- {1}";
                case StringId.PictureEditMenuCut: return "Kes";
                case StringId.PictureEditMenuCopy: return "Kopyala";
                case StringId.PictureEditMenuPaste: return "Yapıştır";
                case StringId.PictureEditMenuDelete: return "Sil";
                case StringId.PictureEditMenuLoad: return "Yükle";
                case StringId.PictureEditMenuSave: return "Kaydet";

                case StringId.FilterClauseEquals: return "Aynıysa";
                case StringId.FilterClauseBeginsWith: return "Başlıyorsa";

                    // ...
            }
            return base.GetLocalizedString(id);
        }
    }

    public class TurkishEditResLocalizer : EditResLocalizer
    {
        public override string Language { get { return "Turkish"; } }
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                // ...
                case StringId.NavigatorTextStringFormat: return "{0} -- {1}";
                case StringId.PictureEditMenuCut: return "Kes";
                case StringId.PictureEditMenuCopy: return "Kopyala";
                case StringId.PictureEditMenuPaste: return "Yapıştır";
                case StringId.PictureEditMenuDelete: return "Sil";
                case StringId.PictureEditMenuLoad: return "Yükle";
                case StringId.PictureEditMenuSave: return "Kaydet";

                case StringId.FilterClauseEquals: return "Aynıysa";
                case StringId.FilterClauseBeginsWith: return "Başlıyorsa";
                case StringId.FilterClauseContains: return "İçeriyorsa";
                case StringId.FilterClauseDoesNotContain: return "İçermiyorsa";
                case StringId.FilterClauseDoesNotEqual: return "Aynı değilse";
                case StringId.FilterClauseEndsWith: return "İle bitiyorsa";
                case StringId.FilterClauseGreater: return "Büyükse";
                case StringId.FilterClauseGreaterOrEqual: return "Büyük veya eşitse";
                case StringId.FilterClauseIsNotNull: return "Boş değilse";
                case StringId.FilterClauseIsNotNullOrEmpty: return "Boş değilse";
                case StringId.FilterClauseIsNull: return "Boşsa";
                case StringId.FilterClauseIsNullOrEmpty: return "Boşsa";
                case StringId.FilterClauseLess: return "Düşükse";
                case StringId.FilterClauseLessOrEqual: return "Düşük veya eşitse";
                case StringId.FilterClauseLike: return "Benzerse";
                    // ...
            }
            return base.GetLocalizedString(id);
        }
    }

    public class TurkishFilterUILocalizer : FilterUIElementResXLocalizer
    {
        public override string Language { get { return "Turkish"; } }
        public override string GetLocalizedString(FilterUIElementLocalizerStringId id)
        {
            switch(id)
            {
                case FilterUIElementLocalizerStringId.CustomUIValueLabel: return "Değer";
                case FilterUIElementLocalizerStringId.CustomUITypeLabel: return "Tip";
                case FilterUIElementLocalizerStringId.FilteringUIClearFilter: return "Filtreyi temizle";
                case FilterUIElementLocalizerStringId.FilteringUIClose: return "Kapat";
                case FilterUIElementLocalizerStringId.FilteringUITabValues: return "Değerler";

                case FilterUIElementLocalizerStringId.CustomUIFiltersTextName: return "Yazı Filtreleri";
                case FilterUIElementLocalizerStringId.CustomUINullValuePromptSearchControl: return "Aramak için yazınız...";
                case FilterUIElementLocalizerStringId.CustomUIFilterBeginsWithName: return "İle başlıyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterBeginsWithDescription: return "Değer ile başlıyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterEqualsName: return "Eşitse";
                case FilterUIElementLocalizerStringId.CustomUIFilterEqualsDescription: return "Değere eşitse";
                case FilterUIElementLocalizerStringId.CustomUIFilterDoesNotEqualName: return "Eşit Değilse";
                case FilterUIElementLocalizerStringId.CustomUIFilterDoesNotEqualDescription: return "Değere Eşit Değilse";
                case FilterUIElementLocalizerStringId.CustomUIFilterEndsWithName: return "İle bitiyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterEndsWithDescription: return "Değer ile bitiyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterContainsName: return "İçeriyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterCustomDescription: return "Değeri içeriyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterDoesNotContainName: return "İçermiyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterDoesNotContainDescription: return "Değeri içermiyorsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsBlankName: return "Boşsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsBlankDescription: return "Boşsa";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsNotBlankName: return "Boş değilse";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsNotBlankDescription: return "Değer boş değilse";
                case FilterUIElementLocalizerStringId.CustomUINullValuePromptSelectAValue: return "Bir değer seçin...";

                case FilterUIElementLocalizerStringId.CustomUIFiltersNumericName: return "Sayısal Filtreler";
                case FilterUIElementLocalizerStringId.CustomUIFiltersNumericDescription: return "Sayısal değerlere ait filtreler";
                case FilterUIElementLocalizerStringId.CustomUIFilterBetweenName: return "Arasında";
                case FilterUIElementLocalizerStringId.CustomUIFilterBetweenDescription: return "Değerlerin arasında ise";
                case FilterUIElementLocalizerStringId.CustomUIFilterGreaterThanName: return "Büyük";
                case FilterUIElementLocalizerStringId.CustomUIFilterGreaterThanDescription: return "Değerden büyükse";
                case FilterUIElementLocalizerStringId.CustomUIFilterGreaterThanOrEqualToName: return "Büyük veya eşit";
                case FilterUIElementLocalizerStringId.CustomUIFilterGreaterThanOrEqualToDescription: return "Değerden büyük veya değere eşit ise";
                case FilterUIElementLocalizerStringId.CustomUIFilterLessThanName: return "Küçükse";
                case FilterUIElementLocalizerStringId.CustomUIFilterLessThanDescription: return "Değerden küçükse";
                case FilterUIElementLocalizerStringId.CustomUIFilterLessThanOrEqualToName: return "Küçük veya eşitse";
                case FilterUIElementLocalizerStringId.CustomUIFilterLessThanOrEqualToDescription: return "Değerden küçük veya değere eşit ise";

                case FilterUIElementLocalizerStringId.CustomUIFiltersDateTimeName: return "Tarih Filtreleri";
                case FilterUIElementLocalizerStringId.CustomUIFiltersDateTimeDescription: return "Tarihe göre filtreleme";
                case FilterUIElementLocalizerStringId.CustomUIFilterYesterdayName: return "Dün";
                case FilterUIElementLocalizerStringId.CustomUIFilterTodayName: return "Bugün";
                case FilterUIElementLocalizerStringId.CustomUIFilterTomorrowName: return "Yarın";
                case FilterUIElementLocalizerStringId.CustomUIFilterLastWeekName: return "Geçen Hafta";
                case FilterUIElementLocalizerStringId.CustomUIFilterThisWeekName: return "Bu Hafta";
                case FilterUIElementLocalizerStringId.CustomUIFilterNextWeekName: return "Sonraki Hafta";
                case FilterUIElementLocalizerStringId.CustomUIFilterLastMonthName: return "Geçen Ay";
                case FilterUIElementLocalizerStringId.CustomUIFilterThisMonthName: return "Bu Ay";
                case FilterUIElementLocalizerStringId.CustomUIFilterNextMonthName: return "Sonraki Ay";
                case FilterUIElementLocalizerStringId.CustomUIFilterLastYearName: return "Geçen Sene";
                case FilterUIElementLocalizerStringId.CustomUIFilterThisYearName: return "Bu Sene";
                case FilterUIElementLocalizerStringId.CustomUIFilterNextYearName: return "Sonraki Sene";
                case FilterUIElementLocalizerStringId.CustomUIFilterDatePeriodsName: return "Belirli Tarih Dönemleri";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsSameDayName: return "Aynı Gün";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsNullName: return "Boş";
                case FilterUIElementLocalizerStringId.CustomUIFilterIsNotNullName: return "Boş Değil";
                case FilterUIElementLocalizerStringId.CustomUIFilterBeforeName: return "Önce";
                case FilterUIElementLocalizerStringId.CustomUIFilterAfterName: return "Sonra";
                case FilterUIElementLocalizerStringId.CustomUIFilterYearToDateName: return "Sene Başından Beri";
                case FilterUIElementLocalizerStringId.CustomUIFilterAllDatesInThePeriodName: return "Tüm Tarihler";
                case FilterUIElementLocalizerStringId.CustomUINullValuePromptSelectADate: return "Bir Tarih Seçin...";

            }
            return base.GetLocalizedString(id);
        }
    }
}
