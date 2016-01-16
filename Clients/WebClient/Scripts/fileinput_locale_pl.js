/*!
 * FileInput <_LANG_> Translations
 *
 * This file must be loaded after 'fileinput.js'. Patterns in braces '{}', or
 * any HTML markup tags in the messages must not be converted or translated.
 *
 * @see http://github.com/kartik-v/bootstrap-fileinput
 *
 * NOTE: this file must be saved in UTF-8 encoding.
 */
(function ($) {
    "use strict";

    $.fn.fileinput.locales._LANG_ = {
        fileSingle: 'plik',
        filePlural: 'pliki',
        browseLabel: 'Pobierz &hellip;',
        removeLabel: 'Usuń',
        removeTitle: 'Wyczść wybrane pliki',
        cancelLabel: 'Anuluj',
        cancelTitle: 'Przerwij przesyłanie',
        uploadLabel: 'Prześlij',
        uploadTitle: 'Prześlij wybrane pliki',
        msgSizeTooLarge: 'Plik "{name}" (<b>{size} KB</b>) przekracza maksymalny rozmiar <b>{maxSize} KB</b>. Spróbuj przesłać jeszcze raz!',
        msgFilesTooLess: 'Musisz wybrać przynajmniej <b>{n}</b> {files} aby przesłać. Spróbuj przesłać jeszcze raz!',
        msgFilesTooMany: 'Liczba plików wysłanych do przesłania <b>({n})</b> przekracza dozwolony limit <b>{m}</b>. Spróbuj przesłać jeszcze raz!',
        msgFileNotFound: 'Plik "{name}" nie został znaleziony!',
        msgFileSecured: 'Nie masz dostępu do pliku "{name}".',
        msgFileNotReadable: 'Plik "{name}" nie może zostać odczytany.',
        msgFilePreviewAborted: 'Podgląd pliku "{name}" został wstrzymany.',
        msgFilePreviewError: 'Podczas odczytu pliku"{name}" wystąpił błąd.',
        msgInvalidFileType: 'Niepoprawny format pliku "{name}". Wspierane typy: "{types}".',
        msgInvalidFileExtension: 'Złe rozszerzenie pliku "{name}". Wspierane rozszerzenia "{extensions}".',
        msgValidationError: 'Błąd przesyłania pliku',
        msgLoading: 'Ładowanie pliku {index} z {files} &hellip;',
        msgProgress: 'Ładowanie pliku {index} z {files} - {name} - {percent}% ukończono.',
        msgSelected: '{n} wybrane pliki',
        msgFoldersNotAllowed: 'Przeciągnij i upuść tylko pliki! Pominięto {n} opuszczno foldery(s).',
        dropZoneTitle: 'Przeciągnij i upuść pliki &hellip;'
    };

    $.extend($.fn.fileinput.defaults, $.fn.fileinput.locales._LANG_);
})(window.jQuery);