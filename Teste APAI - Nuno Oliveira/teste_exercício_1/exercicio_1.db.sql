BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "items" (
	"id"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"name_item"	VARCHAR(60) NOT NULL,
	"quantity"	INTEGER,
	"item_type"	VARCHAR(60) NOT NULL,
	"id_player"	INTEGER NOT NULL,
	FOREIGN KEY("id_player") REFERENCES "player"("id_player"),
	FOREIGN KEY("item_type") REFERENCES "type_item"("id")
);
CREATE TABLE IF NOT EXISTS "type_item" (
	"id"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"type"	VARCHAR(60) NOT NULL
);
CREATE TABLE IF NOT EXISTS "player" (
	"id_PLAYER"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"name"	VARCHAR(60) NOT NULL
);
INSERT INTO "items" VALUES (1,'Blades of Chaos',1,'1',1);
INSERT INTO "type_item" VALUES (1,'Damage');
INSERT INTO "player" VALUES (1,'NunoAlex221');
INSERT INTO "player" VALUES (2,'Zeus');
INSERT INTO "player" VALUES (3,'Ares');
INSERT INTO "player" VALUES (4,'Kratos');
INSERT INTO "player" VALUES (5,'Athena');
COMMIT;
