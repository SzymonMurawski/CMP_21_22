document.addEventListener("DOMContentLoaded",
    function(){


        let list = document.getElementById("todoList");
        list.addEventListener(
            "click",
            function(event) {
                event.target.classList.toggle("checked");
            }
        );

    }

);

function addTodo(what){
    let li = document.createElement('li');
    li.appendChild(document.createTextNode(what));
    document.getElementById("todoList").appendChild(li);
}