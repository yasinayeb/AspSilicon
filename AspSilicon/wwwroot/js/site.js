document.addEventListener('DOMContentLoaded', function () {
    select();
    handleProfileImageUpload();
});

function select() {
    try {
        let select = document.querySelector('.select');
        let selected = select.querySelector('.selected');
        let selectOptions = select.querySelector('.select-options');

        selected.addEventListener('click', function () {
            selectOptions.style.display = (selectOptions.style.display === 'block') ? 'none' : 'block';
        });

        let options = selectOptions.querySelectorAll('.option');
        options.forEach(function (option) {
            option.addEventListener('click', function () {
                selected.innerHTML = this.textContent;
                selectOptions.style.display = 'none';
                let category = this.getAttribute('data-value');
            });
        });
    } catch (error) {
        console.error(error);
    }
}

function handleProfileImageUpload() {
    try {

        let fileUploader = document.querySelector('#fileUploader')
        if (fileUploader != undefined) {
            fileUploader.addEventListener('change', function () {
                if (this.files.length > 0) {
                    this.form.submit()
                }
            })
        }

    }
    catch { }
}