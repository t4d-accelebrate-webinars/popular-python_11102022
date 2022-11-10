# Setup Jupyter Labs


1. Create a new Virtual Environment.

```
python -m venv venv
```

2. Activate the new Virtual Environment

Windows

```
.\venv\Scripts\activate
```

macOS/Linux

```
source ./venv/bin/activate
```

2. Install Jupyter Labs and other commonly used packages.

```bash
python -m pip install jupyterlab numpy matplotlib pandas ipykernel
```

3. Install a new kernel using the new Virtual Environment.

```bash
python -m ipykernel install --user --name=venv
```

4. Run Jupyter Labs.

```bash
jupyter-lab
```