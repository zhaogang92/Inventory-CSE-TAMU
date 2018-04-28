#!/bin/python

from __future__ import print_function

import os, sys

def main():
    if len(sys.argv) < 2:
        print("Please the target type!")
        exit(-1)
    type = int(sys.argv[1])
    if len(sys.argv) < 3:
        print("Please provide at least one target file.")
        exit(-1)
    i = 2
    if type == 0: # description
        descriptions = set()
        while i < len(sys.argv):
            lines = open(sys.argv[i], 'r').readlines()
            for line in lines[1:]:
                data = line.replace('"', '').strip()
                if len(data) > 0:
                    descriptions.add(data)
            i += 1
        output_name = os.path.join(os.path.dirname(sys.argv[2]), "sug_descriptions.txt")
        with open(output_name, "w") as fout:
            fout.writelines("\n".join(descriptions))
    elif type == 1: # staff name
        first_name = set()
        last_name = set()
        while i < len(sys.argv):
            lines = open(sys.argv[i], 'r').readlines()
            for line in lines[1:]:
                name = line.replace('"', '').replace('.', '').strip()
                first_name.add(name.split(",")[1].strip())
                last_name.add(name.split(",")[0].strip())
            i += 1
        output_name = os.path.join(os.path.dirname(sys.argv[2]), "sug_first_name.txt")
        with open(output_name, "w") as fout:
            fout.writelines("\n".join(first_name))
        output_name = os.path.join(os.path.dirname(sys.argv[2]), "sug_last_name.txt")
        with open(output_name, "w") as fout:
            fout.writelines("\n".join(last_name))
    elif type == 2: # model
        models = set()
        while i < len(sys.argv):
            lines = open(sys.argv[i], 'r').readlines()
            for line in lines[1:]:
                data = line.replace('"', '').replace('.', '').replace('?', '').strip()
                if len(data) > 0:
                    models.add(data)
            i += 1
        output_name = os.path.join(os.path.dirname(sys.argv[2]), "sug_models.txt")
        with open(output_name, "w") as fout:
            fout.writelines("\n".join(models))

if __name__ == "__main__":
    main()