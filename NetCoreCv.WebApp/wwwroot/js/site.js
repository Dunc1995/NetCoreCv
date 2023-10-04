// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const setupButtonLinks = () => {
    const body = document.querySelector('body');

    body.onclick = async (e) => {
        const target = e.target;
        const buttonType = target.getAttribute('type');

        if (target.tagName === 'BUTTON' && buttonType === 'link') {
            const location = target.getAttribute('href');
            window.location.href = `${window.location.href}/${location}`;
        };
    }
}

const setupDeletableLists = () => {
    // FIXME: will break if there's more than one deletable list on the page.
    const list = document.querySelector('ul.deletable');

    if (!list) return;

    list.onclick = async (e) => {
        const target = e.target;
        const itemId = target.getAttribute('item-id');

        if (target.tagName === 'A' && itemId) {
            const response = await fetch(`${window.location.href}/Delete/${itemId}`, {
                method: 'DELETE'
            });

            if (response.ok) {
                target.closest('li').remove();
            }
        };
    }
}

const defaultCreateOrUpdateFormSubmit = async (e) => {
    e.preventDefault();

    const form = document.querySelector('form');

    if (!form) return; // Do nothing if no form exists.

    const data = new FormData(form);
    const jsonData = Object.fromEntries(data.entries());

    await fetch("Edit", {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(jsonData)
    });
}

document.onsubmit = defaultCreateOrUpdateFormSubmit;
window.onload = () => {
    setupButtonLinks();
    setupDeletableLists();
}