CREATE TABLE player(
   id_PLAYER INTEGER PRIMARY KEY AUTOINCREMENT,
   name VARCHAR(60) NOT NULL
);

CREATE TABLE type_item(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    type VARCHAR (60) NOT NULL
);

CREATE TABLE items (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name_item VARCHAR(60) NOT NULL,
    quantity INTEGER NULL,
    type_item VARCHAR(60) NOT NULL,
    id_player INTEGER NOT NULL,
    FOREIGN KEY (id_player) REFERENCES player(id_player),
    FOREIGN KEY (type_item) REFERENCES type_item(id)
);


